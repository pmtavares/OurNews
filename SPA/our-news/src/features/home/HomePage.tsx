import React, {useState, useEffect, Fragment} from 'react';
import { Header, Icon, List, ListItem, Container, Grid, Advertisement, Segment } from 'semantic-ui-react'
import { IArticle } from '../../app/models/article';

import agent from '../../app/api/agent';
import NavBar from '../../features/nav/NavBar';
import BreakingNews from '../articles/BreakingNews';
import FrontArticles from '../articles/FrontArticles';
import TopNews from '../articles/TopNews';
import SecondaryArticles from '../articles/SecondaryArticles';
import ArticleByCategory from '../articles/ArticleByCategory';
import Footer from '../nav/Footer';


const HomePage = () => {
    const [articles, setArticles] = useState<IArticle[]>([]);

    useEffect(() => {
  
      agent.Articles.listLatest().then(response => {
        setArticles(response)
      });
  
      return () => {
        
      }
    }, [])

    return (
        <Fragment>
            <NavBar></NavBar>
            <Container>
                <BreakingNews />
                <FrontArticles />
                <TopNews />
                <Grid>
                    <Grid.Row columns={2}>
                        <Grid.Column width={11}>
                            <SecondaryArticles />
                        </Grid.Column>
                        <Grid.Column width={5}>
                            <Grid.Column>
                                <Segment>
                                    <Advertisement unit='half page' test='Half Page' />
                                </Segment>
                            </Grid.Column>
                            <Grid.Column>
                                <Segment>
                                    <Advertisement unit='medium rectangle' test='Medium Rectangle' />
                                </Segment>

                            </Grid.Column>
                        </Grid.Column>

                    </Grid.Row>
                    <Grid.Row>
                        <Grid.Column width={11}>
                            <ArticleByCategory />
                        </Grid.Column>
                        <Grid.Column width={5}>
                            <Segment>
                                <Advertisement unit='medium rectangle' test='Medium Rectangle' />
                            </Segment>
                        </Grid.Column>
                    </Grid.Row>

                </Grid>                
                
            </Container>
            <Footer />        

    </Fragment>
    )
    
}

export default HomePage
